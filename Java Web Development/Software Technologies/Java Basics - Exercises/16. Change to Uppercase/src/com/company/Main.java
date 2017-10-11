package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String text = scan.nextLine();

        for (int i = 0; i < text.length(); i++) {

            int firstIndex = text.indexOf("<upcase>");
            int lastIndex = text.indexOf("</upcase>");

            if (firstIndex < 0){
                break;
            }

            String textForChange = text.substring(firstIndex, lastIndex + 9);
            String changeText = text.substring(firstIndex + 8, lastIndex).toUpperCase();

            text = text.replace(textForChange, changeText);
        }

        System.out.println(text);
    }
}
