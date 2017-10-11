package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int number = scanner.nextInt();

        for (int i = 1; i <= number; i++) {
            String numToStr = Integer.toString(i);

            if (isSymetric(numToStr))
            {
                System.out.print(i + " ");
            }
        }
    }

    private static boolean isSymetric(String numToStr) {
        for (int j = 0; j < numToStr.length() / 2; j++) {
            char firstChar = numToStr.charAt(j);
            char lastChar = numToStr.charAt(numToStr.length() - j - 1);

            if (firstChar != lastChar){
                return false;
            }
        }
        return true;
    }
}
