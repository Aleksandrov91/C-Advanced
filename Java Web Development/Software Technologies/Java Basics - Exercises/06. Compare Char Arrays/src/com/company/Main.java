package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] firstArr = scan.nextLine().split(" ");
        String[] secondArr = scan.nextLine().split(" ");

        if (firstArr.length < secondArr.length){
            System.out.println(String.join("", firstArr));
            System.out.println(String.join("", secondArr));
        } else if (secondArr.length < firstArr.length) {
            System.out.println(String.join("", secondArr));
            System.out.println(String.join("", firstArr));
        } else {
            int equals = 0;

            for (int i = 0; i < firstArr.length; i++) {
                equals = firstArr[i].compareTo(secondArr[i]);
            }

            if(equals >= 0) {
                System.out.println(String.join("", secondArr));
                System.out.println(String.join("", firstArr));
            } else {
                System.out.println(String.join("", firstArr));
                System.out.println(String.join("", secondArr));
            }
        }
    }
}
