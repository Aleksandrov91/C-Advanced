package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int input = scan.nextInt();

        String binary = Integer.toBinaryString(input);
        String hexadecimal = Integer.toHexString(input).toUpperCase();

        System.out.println(hexadecimal);
        System.out.println(binary);
    }
}
