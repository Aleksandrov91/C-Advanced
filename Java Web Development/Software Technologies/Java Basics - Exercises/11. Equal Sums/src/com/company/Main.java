package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split(" ");

        int[] numbers = new int[input.length];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(input[i]);
        }

        for (int i = 0; i < numbers.length; i++) {

            int[] leftPart = Arrays.copyOfRange(numbers, 0 , i);
            int[] rightPart = Arrays.copyOfRange(numbers, i + 1 , numbers.length);

            int leftSum = sum(leftPart);
            int rightSum = sum(rightPart);

            if (leftSum == rightSum) {
                System.out.print(i);
                return;
            }
        }

        System.out.print("no");
    }

    private static int sum(int[] arr) {
        int sum = 0;
        for (int i = 0; i < arr.length; i++) {
            sum += arr[i];
        }
        return sum;
    }
}
