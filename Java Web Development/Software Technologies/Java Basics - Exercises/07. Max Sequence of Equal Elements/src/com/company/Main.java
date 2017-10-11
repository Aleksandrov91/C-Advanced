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
        int maxElement = 0;

        for (int i = 1; i < numbers.length; i++) {
            int currentNum = numbers[i];
            int previousNum = numbers[i - 1];

            if (currentNum == previousNum){
                count++;
            } else {
                if (count > maxCount){
                    maxCount = count;
                    maxElement = previousNum;
                }
                count = 1;
            }
        }

        if (count > maxCount){
            maxCount = count;
            maxElement = numbers[numbers.length - 1];
        }

        for (int i = 0; i < maxCount; i++) {
            System.out.print(maxElement + " ");
        }
    }
}
