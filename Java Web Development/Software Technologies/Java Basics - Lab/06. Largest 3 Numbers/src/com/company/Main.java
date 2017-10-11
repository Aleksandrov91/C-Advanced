package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split(" ");

        int[] numbers = new int[input.length];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(input[i]);
        }

        Arrays.sort(numbers);

        int count = 0;
        for (int i = numbers.length - 1; i >= 0; i--) {
            if (count == 3){
                return;
            }

            System.out.print(numbers[i] + " ");
            count++;
        }
    }
}
