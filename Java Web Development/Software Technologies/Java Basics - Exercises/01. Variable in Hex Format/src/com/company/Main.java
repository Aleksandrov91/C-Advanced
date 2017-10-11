package com.company;

import javax.sound.midi.SysexMessage;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);

	int result = Integer.parseInt(scanner.next(), 16);

	System.out.print(result);
    }
}
