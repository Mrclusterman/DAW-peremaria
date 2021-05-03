package Controller;

import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javax.swing.JOptionPane;
import javafx.event.ActionEvent;

public class Calculadora {
	
	private long num1;
	private String operator = "";
	private boolean start = true;
    
	@FXML
    private Label output;

	
	@FXML
	private void processNumPad(ActionEvent event) {
		if (start) {
			output.setText("");
			start = false;
		}
		String value = ((Button)event.getSource()).getText();
		output.setText(output.getText() + value);
	}

	
	@FXML
	private void processOperator(ActionEvent event) {
		if (output.getText().equals("ERROR")) {
			return;
		}
		String value = ((Button)event.getSource()).getText();
		if(!value.equals("=")) {
			if(!operator.isEmpty()) {
				return;
			}
			operator = value;
			num1 = Long.parseLong(output.getText());
			output.setText("");
		} else {
			if (operator.isEmpty()) {
				return;
			}
			if (output.getText().isEmpty()) {
				output.setText("ERROR");
				operator = "";
				start = true;
			}
			output.setText(calcular(num1, Long.parseLong(output.getText()), operator));
			operator = "";
			start = true;
			return;
		}
	}
	
	@FXML
	private void limpiarOutput(ActionEvent event) {
		output.setText("0");
		start = true;
		operator = "";
		
	}
	
	
	private String calcular(long num1, long num2, String op) {
		switch (op) {
		case "+":
			return String.valueOf(num1 + num2);
		case "-":
			return String.valueOf(num1 - num2);
		case "×":
			return String.valueOf(num1 * num2);
		case "÷":
			if (num2 == 0) {
				return "ERROR";
			}
			return String.valueOf(num1 / num2);
		}
		return "ERROR";
	}
}
