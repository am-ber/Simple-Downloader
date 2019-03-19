package core;

import core.elements.Downloader;
import core.elements.GUIStruct;

public class DownloaderThread extends Thread {
	
	public GUIStruct struct;
	private Downloader downloader;
	
	public DownloaderThread(GUIStruct struct) {
		this.struct = struct;
		downloader = new Downloader();
	}
	
	public void run() {
		downloader.Download(struct.getUrl(), struct.getLocation());
		interrupt();
	}

}
