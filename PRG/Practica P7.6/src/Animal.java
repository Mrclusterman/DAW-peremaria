public abstract class Animal extends Ser_Vivo {

	private int numPatas;

	public int getNumPatas() {
		return numPatas;
	}

	public void setNumPatas(int numPatas) {
		this.numPatas = numPatas;
	}
	public String toString() {
		
		return super.toString() + "\nTengo: " + this.numPatas + " patas.";
	}
}
