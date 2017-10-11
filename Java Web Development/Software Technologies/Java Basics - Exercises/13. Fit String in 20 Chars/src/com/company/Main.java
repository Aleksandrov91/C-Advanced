package com.company;


import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String text = scan.nextLine();
        String result = "";

        if (text.length() > 20){
            result = text.substring(0, 20);
        } else {
            result = text;
            for (int i = result.length(); i < 20 ; i++) {
                result += '*';
            }
        }
        System.out.print(result);
    }
}
