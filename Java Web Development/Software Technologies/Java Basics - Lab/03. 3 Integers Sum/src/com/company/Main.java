package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int firstNum = scan.nextInt();
        int secondNum = scan.nextInt();
        int thirdNum = scan.nextInt();

        if (!checkNums(firstNum, secondNum, thirdNum)
                && !checkNums(thirdNum, firstNum, secondNum)
                && !checkNums(secondNum, thirdNum, firstNum)){
            System.out.println("No");
        }
    }

    public static boolean checkNums(int firstNum, int secondNum, int sum) {
        if (firstNum + secondNum == sum){
            if (firstNum > secondNum){
                int temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;
            }

            System.out.printf("%d + %d = %d", firstNum, secondNum, sum);
            return true;
        }

        return false;
    }
}
