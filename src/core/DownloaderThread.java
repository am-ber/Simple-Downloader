package core;

import core.elements.GUIStruct;
import tools.CP;

public class DownloaderThread extends Thread {
	
	private GUIStruct struct;
	
	public DownloaderThread(GUIStruct struct) {
		this.struct = struct;
	}
	
	public void run() {
		while (!Thread.currentThread().isInterrupted()) {
			try {
				
				// Waits 0.75 seconds to update
				Thread.sleep(750);
				
			} catch (InterruptedException ex) {
				// Will safely exit the thread
				CP.println("--- Thread interrupted.");
				Thread.currentThread().interrupt();
				break;
			} catch (Exception e) {
				// If the webpage isn't loaded yet it will
				CP.println("--- No webpage yet.");
				try {
					Thread.sleep(2000);
				} catch (Exception e1) {
					CP.println("--- Something else happened.");
				}
			}
		}
	}

}
