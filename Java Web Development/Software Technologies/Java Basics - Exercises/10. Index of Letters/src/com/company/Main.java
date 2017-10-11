package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        char[] characters = scan.nextLine().toCharArray();

        for (int i = 0; i < characters.length; i++) {
            char currentChar = characters[i];
            int currentPositionInAlphabet = characters[i] - 'a';

            System.out.printf("%s -> %d %n", currentChar, currentPositionInAlphabet);
        }
    }
}
