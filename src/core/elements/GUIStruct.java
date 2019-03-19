package core.elements;

public class GUIStruct {
	
	private String url = "";
	private String location = "";
	
	public GUIStruct(String url, String location) {
		this.url = url;
		this.location = location;
	}
	
	public String getUrl() {
		return url;
	}
	
	public String getLocation() {
		return location;
	}
}
