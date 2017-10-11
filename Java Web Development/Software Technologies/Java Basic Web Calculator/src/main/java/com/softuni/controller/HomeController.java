package com.softuni.controller;

import com.softuni.entity.Calculator;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class HomeController {
	@GetMapping("/")
	public String index(Model model) {
		model.addAttribute("operator", "+");
		model.addAttribute("view", "views/calculatorForm");
		return "base-layout";
	}

	@PostMapping("/")
	public String calculate(@RequestParam String leftOperand,
							@RequestParam String rightOperand,
							@RequestParam String operator,
							Model model){
		double firstNum;
		double secondNum;
		String leftError = "";
		String rightError = "";

		try {
			firstNum = Double.parseDouble(leftOperand);
		} catch (NumberFormatException ex){
			firstNum = 0;
			leftError = "Error";
		}

		try {
			secondNum = Double.parseDouble(rightOperand);
		} catch (NumberFormatException ex){
			secondNum = 0;
			rightError = "Error";
		}

		Calculator calculator = new Calculator(firstNum, operator, secondNum);

		double result = calculator.calculateResult();

		if	(leftError.length() > 1){
			model.addAttribute("leftOperand", leftError);
			model.addAttribute("result", leftError);
		} else {
			model.addAttribute("leftOperand", calculator.getLeftOperand());
		}

        model.addAttribute("operator", calculator.getOperator());

		if (rightError.length() > 1){
			model.addAttribute("rightOperand", rightError);
			model.addAttribute("result", rightError);
		} else {
			model.addAttribute("rightOperand", calculator.getRightOperand());
		}

		if (rightError.length() > 1 || leftError.length() > 1){
			model.addAttribute("result", "Error");
		} else {
			model.addAttribute("result", result);
		}

		model.addAttribute("view", "views/calculatorForm");

		return "base-layout";
	}
}
