package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);

	double firstNum = scanner.nextDouble();
	double secondNum = scanner.nextDouble();

	double result = firstNum + secondNum;

	System.out.println(result);
    }
}
