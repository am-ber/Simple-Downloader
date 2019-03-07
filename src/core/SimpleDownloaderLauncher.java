package core;

import core.elements.Downloader;
import core.elements.DownloaderUI;
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.layout.GridPane;
import javafx.stage.Stage;
import tools.CP;

public class SimpleDownloaderLauncher extends Application {
	
	private Scene mainScene;
	private GridPane mainPane;
	
	private DownloaderUI downloaderUI;
	private Downloader downloader;

	public static void main(String[] args) {
		CP.println("Launching Downloader.");
		launch(args);
	}
	
	public void start(Stage primary) throws Exception {
		mainPane = new GridPane();
		mainScene = new Scene(mainPane, 375, 75);
		downloader = new Downloader();
		downloaderUI = new DownloaderUI(this, downloader);
		
		mainPane.add(downloaderUI, 0, 0);
		
		primary.setResizable(false);
		primary.setTitle("Simple Downloader");
		primary.setScene(mainScene);
		primary.show();
	}
}
