package core.elements;

import java.io.File;
import java.util.ArrayList;

import core.DownloaderThread;
import core.DownloaderUIThread;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Insets;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import javafx.scene.input.KeyCode;
import javafx.scene.input.KeyEvent;
import javafx.scene.layout.GridPane;
import javafx.stage.DirectoryChooser;
import javafx.stage.Stage;
import tools.CP;

public class DownloaderUI extends GridPane {
	
	private TextField searchField;
	private TextField locationField;
	private Button changeLocationButton;
	private Button downloadButton;
	private Label title;
	private Label linkLabel;
	private Label locationLabel;
	
	public DownloaderUIThread dlUIThread;
	private Stage primary;
	private GridPane contentPane;
	@SuppressWarnings("rawtypes")
	private TableView downloadTable;
	@SuppressWarnings("rawtypes")
	private TableColumn jobColumn;
	@SuppressWarnings("rawtypes")
	private TableColumn statusColumn;
	private ArrayList<DownloaderThread> threadList;
	
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
					threadList.add(new DownloaderThread(new GUIStruct(searchField.getText(), locationField.getText())));
				clearFields();
			}
		});
		add(downloadButton, 0, 1);
		
		searchField = new TextField("https://www.youtube.com/watch?v=dppE0xtHzWU");
		searchField.setOnKeyPressed(new EventHandler<KeyEvent>() {
			@Override
			public void handle(KeyEvent t) {
				if (t.getCode() == KeyCode.ENTER) {
					if (searchField.getText().equals(""))
						CP.println("Search field is empty");
					else
						threadList.add(new DownloaderThread(new GUIStruct(searchField.getText(), locationField.getText())));
					clearFields();
				}
			}
		});
		searchField.setPrefColumnCount(24);
		contentPane.add(searchField, 0, 2);
		
		locationField = new TextField("c:\\");
		locationField.setPrefColumnCount(24);
		contentPane.add(locationField, 0, 4);
		
		downloadTable = new TableView();
		downloadTable.setEditable(true);
		jobColumn = new TableColumn("Job");
		statusColumn = new TableColumn("Status");
		downloadTable.getColumns().addAll(jobColumn, statusColumn);
		add(downloadTable, 0, 2);
		
		dlUIThread.start();
	}
	
	@SuppressWarnings({ "static-access", "unchecked" })
	public void checkJobList() {
		if (!threadList.isEmpty()) {
			for (DownloaderThread dT : threadList) {
				// Will check if the thread has started
				if (dT.started) {
					if (dT.finished) {
						dT.interrupt();
						if (threadList.remove(dT)) {
							CP.println("Removed job: " + dT.getId());
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
	
	public void clearFields() {
		searchField.setText("");
	}
}
