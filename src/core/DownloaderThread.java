package core;

import core.elements.Downloader;
import core.elements.GUIStruct;
import tools.CP;

public class DownloaderThread extends Thread {
	
	public GUIStruct struct;
	private Downloader downloader;
	public boolean started = false;
	public boolean finished = false;
	
	public DownloaderThread(GUIStruct struct) {
		this.struct = struct;
		downloader = new Downloader();
	}
	
	public void run() {
		started = true;
		struct.setStatus("Downloading...");
		downloader.Download(struct.getUrl(), struct.getLocation());
		struct.setStatus("Done");
		CP.println("Downloader finished for: " + struct.getJobID());
		finished = true;
	}
}
