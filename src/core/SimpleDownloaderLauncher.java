package core;

import java.io.File;
import java.net.URL;

import core.elements.DownloaderUI;
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.layout.GridPane;
import javafx.stage.Stage;
import tools.CP;

public class SimpleDownloaderLauncher extends Application {
	
	public static final String FILE_DEST = "c:/sd/youtube-dl.exe";
	
	private Scene mainScene;
	private GridPane mainPane;
	private DownloaderUI downloaderUI;

	public static void main(String[] args) {
		CP.println("Launching Downloader.");
		launch(args);
	}
	
	public void start(Stage primary) throws Exception {
		setup();
		mainPane = new GridPane();
		mainScene = new Scene(mainPane, 300, 500);
		downloaderUI = new DownloaderUI(primary);
		
		mainPane.add(downloaderUI, 0, 0);
		
		primary.setResizable(false);
		primary.setTitle("Simple Downloader");
		primary.setScene(mainScene);
		primary.show();
	}
	
	private boolean initCheck() {
		File check = new File(FILE_DEST);
		return check.isFile();
	}
	
	private void setup() {
		if (initCheck()) {
			CP.println("File is already there!");
		} else {
			URL inputURL = getClass().getResource("/lib/youtube-dl.exe");
			File dest = new File("c:/sd");
			
			// Check the directory existence
			if (!dest.isDirectory()) {
				CP.println("Creating directory: " + dest.getPath());
				try {
					// It will try to make the directory
					if (dest.mkdir()) {
						CP.println("Created directory.");
					} else {
						CP.println("This thing's garbage. Can't even make a directory.");
					}
				} catch (SecurityException e) {
					CP.println("Don't have permissions to make the directory or file here.");
				}
			} else {
				CP.println("Cool, this directory already exists. But I gotta make sure the exe is there...");
			}
			
			dest = new File(FILE_DEST);
			// Check the file existence
			if (!dest.isFile()) {
				CP.println("Creating file: " + dest.getPath());
				try {
					
				} catch (Exception e) {
					CP.println("So this happened... \n" + e.getMessage());
				}
			}
			
			CP.println("Even though the copying file didn't work, it can still run.\nThis will be fixed later.");
		}
	}
	
	public void stop() {
		downloaderUI.dlUIThread.interrupt();
		if (downloaderUI.threadList.isEmpty()) {
			for (DownloaderThread t : downloaderUI.threadList) {
				t.interrupt();
				if (t.isInterrupted())
					CP.println("Downloader Thread: " + t.struct.getJobID() + " closed safely.");
			}
		}
		if (downloaderUI.dlUIThread.isInterrupted())
			CP.println("DownloaderUI Thread closed safely.");
	}
}
