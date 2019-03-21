package core.elements;

import javafx.beans.property.SimpleStringProperty;

public class GUIStruct {
	
	private SimpleStringProperty jobID;
	private SimpleStringProperty status;
	private String url = "";
	private String location = "";
	
	public GUIStruct(String url, String location, String jobID, String status) {
		this.url = url;
		this.location = location;
		
		this.jobID = new SimpleStringProperty(jobID);
		this.status = new SimpleStringProperty(status);
	}
	
	public String getJobID() {
		return jobID.get();
	}

	public void setJobID(String jobID) {
		this.jobID.set(jobID);
	}

	public String getStatus() {
		return status.get();
	}

	public void setStatus(String status) {
		this.status.set(status);
	}
	
	public String getUrl() {
		return url;
	}
	
	public String getLocation() {
		return location;
	}
}
