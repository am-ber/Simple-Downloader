package core;

import tools.CP;

public class DownloaderUIThread extends Thread {
	
	public void run() {
		while (!Thread.currentThread().isInterrupted()) {
			try {
				
				// Waits 1 seconds to update
				Thread.sleep(1000);
				
			} catch (InterruptedException ex) {
				// Will safely exit the thread
				CP.println("--- Thread interrupted.");
				Thread.currentThread().interrupt();
				return;
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
