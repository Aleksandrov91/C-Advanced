package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split(" ");

        int[] numbers = new int[input.length];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(input[i]);
        }

        int count = 1;
        int maxCount = 0;
        int frequentNum = 0;
        for (int i = 0; i < numbers.length; i++) {
            int currentNum = numbers[i];

            for (int j = i + 1; j < numbers.length; j++) {
                int numForCheck = numbers[j];

                if (currentNum == numForCheck) {
                    count++;
                }
            }

            if (count > maxCount){
                frequentNum = currentNum;
                maxCount = count;
            }
            count = 1;
        }

        System.out.println(frequentNum);
    }
}
