package jdbc_test;

public class node {
	public node() {}
	public node(int gid, String id, String statnnm, String linenum, String transfer){
		setGid(gid);
		setId(id);
		setStatnnm(statnnm);
		setLinenum(linenum);
		setTransfer(transfer);
	}
	public int getGid() {
		return gid;
	}
	public void setGid(int gid) {
		this.gid = gid;
	}
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	public String getStatnnm() {
		return statnnm;
	}
	public void setStatnnm(String statnnm) {
		this.statnnm = statnnm;
	}
	public String getLinenum() {
		return linenum;
	}
	public void setLinenum(String linenum) {
		this.linenum = linenum;
	}
	public String getTransfer() {
		return transfer;
	}
	public void setTransfer(String transfer) {
		this.transfer = transfer;
	}
	int gid;
	String id;
	String statnnm;
	String linenum;
	String transfer;
	
	
}
