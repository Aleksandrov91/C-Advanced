package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.next();

        char check = input.charAt(0);

        if(Character.isDigit(check)){
            System.out.print("digit");
        } else if(check == 'a' || check == 'e'
                || check == 'i' || check == 'o' || check == 'u'){
            System.out.print("vowel");
        } else {
            System.out.print("other");
        }
    }
}
