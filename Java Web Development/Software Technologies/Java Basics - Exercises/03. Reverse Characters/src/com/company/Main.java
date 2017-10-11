package com.company;

import java.util.Scanner;
import java.util.stream.StreamSupport;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();
        input += scan.nextLine();
        input += scan.nextLine();

        char[] result = input.toCharArray();

        for (int i = 0; i < result.length / 2; i++) {
            char temp = result[i];
            result[i] = result[result.length - i - 1];
            result[result.length - i - 1] = temp;
        }

        System.out.print(result);
    }
}
