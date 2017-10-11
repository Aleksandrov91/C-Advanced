package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        boolean input = Boolean.parseBoolean(scan.next());

        if (input){
            System.out.print("Yes");
        } else {
            System.out.print("No");
        }
    }
}
