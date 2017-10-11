package com.company;


import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String text = scan.nextLine();
        String reversedText = "";
        for (int i = 0; i < text.length(); i++) {
            reversedText += text.charAt(text.length() - 1 - i);
        }

        System.out.print(reversedText);
    }
}
