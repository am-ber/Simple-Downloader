package core.elements;

import java.io.File;
import java.util.ArrayList;

import core.DownloaderThread;
import core.DownloaderUIThread;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Insets;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.input.KeyCode;
import javafx.scene.input.KeyEvent;
import javafx.scene.layout.GridPane;
import javafx.stage.DirectoryChooser;
import javafx.stage.Stage;
import tools.CP;

public class DownloaderUI extends GridPane {
	
	// Textfields
	private TextField searchField;
	private TextField locationField;
	
	// Buttons
	private Button changeLocationButton;
	private Button downloadButton;
	
	// Labels
	private Label title;
	private Label linkLabel;
	private Label locationLabel;
	
	// Thread handling
	public DownloaderUIThread dlUIThread;
	public ArrayList<DownloaderThread> threadList;
	private int jobCount = 0;
	
	// Stages and layouts
	private Stage primary;
	private GridPane contentPane;
	
	// Table related
	private TableView<GUIStruct> downloadTable;
	@SuppressWarnings("rawtypes")
	private TableColumn jobColumn;
	@SuppressWarnings("rawtypes")
	private TableColumn statusColumn;
	private ObservableList<GUIStruct> downloadList;
	
	public DownloaderUI(Stage primary) {
		this.primary = primary;
		threadList = new ArrayList<DownloaderThread>();
		contentPane = new GridPane();
		dlUIThread = new DownloaderUIThread(this);
		
		contentPane.setPadding(new Insets(10, 10, 10, 10));
		contentPane.setVgap(5);
		contentPane.setHgap(5);
		
		initNodes();
		add(contentPane, 0, 0);
	}
	
	@SuppressWarnings({ "unchecked", "rawtypes" })
	public void initNodes() {
		title = new Label("Simple Downloader");
		title.setStyle("-fx-font-size: 15pt;");
		contentPane.add(title, 0, 0);
		
		linkLabel = new Label("YouTube Link:");
		contentPane.add(linkLabel, 0, 1);
		
		locationLabel = new Label("Save Location:");
		contentPane.add(locationLabel, 0, 3);
		
		changeLocationButton = new Button("Change Location");
		changeLocationButton.setOnAction(new EventHandler<ActionEvent>() {
			@Override
			public void handle(ActionEvent arg0) {
				DirectoryChooser chooser = new DirectoryChooser();
				chooser.setTitle("JavaFX Projects");
				File defaultDirectory = new File("c:/");
				chooser.setInitialDirectory(defaultDirectory);
				File selectedDirectory = chooser.showDialog(primary);
				locationField.setText(selectedDirectory.getAbsolutePath());
			}
		});
		contentPane.add(changeLocationButton, 1, 1);
		
		downloadButton = new Button("Download");
		downloadButton.setOnAction(new EventHandler<ActionEvent>() {
			@Override
			public void handle(ActionEvent arg0) {
				if (searchField.getText().equals(""))
					CP.println("Search field is empty");
				else
					addJob();
				clearFields();
			}
		});
		add(downloadButton, 0, 1);
		
		// Default video "Bustin every other beat"
		searchField = new TextField("https://www.youtube.com/watch?v=dppE0xtHzWU");
		searchField.setOnKeyPressed(new EventHandler<KeyEvent>() {
			@Override
			public void handle(KeyEvent t) {
				if (t.getCode() == KeyCode.ENTER) {
					if (searchField.getText().equals(""))
						CP.println("Search field is empty");
					else
						addJob();
					clearFields();
				}
			}
		});
		searchField.setPrefColumnCount(24);
		contentPane.add(searchField, 0, 2);
		
		locationField = new TextField("c:\\");
		locationField.setPrefColumnCount(24);
		contentPane.add(locationField, 0, 4);
		
		downloadList = FXCollections.observableArrayList();
		downloadTable = new TableView<GUIStruct>();
		downloadTable.setEditable(true);
		
		jobColumn = new TableColumn("Job");
		jobColumn.setMinWidth(50);
		jobColumn.setCellValueFactory(new PropertyValueFactory<>("jobID"));
		statusColumn = new TableColumn("Status");
		statusColumn.setMinWidth(100);
		statusColumn.setCellValueFactory(new PropertyValueFactory<>("status"));
		
		downloadTable.getColumns().addAll(jobColumn, statusColumn);
		downloadTable.setItems(downloadList);
		add(downloadTable, 0, 2);
		
		dlUIThread.start();
	}
	
	public void checkJobList() {
		if (!threadList.isEmpty()) {
			downloadTable.refresh();
			for (DownloaderThread dT : threadList) {
				// Will check if the thread has started
				if (dT.started) {
					if (dT.finished) {
						dT.interrupt();
						if (threadList.remove(dT)) {
							CP.println("Removed thread: " + dT.getId());
							return;
						}
					}
				} else {
					dT.run();
				}
			}
			
		} else {
			CP.println("No jobs to run...");
		}
	}
	
	public void addJob() {
		jobCount ++;
		DownloaderThread dT = new DownloaderThread(new GUIStruct(searchField.getText(), locationField.getText(), "" + jobCount, "waiting"));
		downloadList.add(dT.struct);
		threadList.add(dT);
	}
	
	public void clearFields() {
		searchField.setText("");
	}
}
