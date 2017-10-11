package com.company;

import java.util.*;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split(" ");

        int[] numbers = new int[input.length];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(input[i]);
        }

        List<Integer> result = new ArrayList<>();
        List<Integer> temp = new ArrayList<>();
        int count = 0;
        int maxCount = 0;
        int previousNum = numbers[0];
        for (int i = 1; i < numbers.length; i++) {
            int currentNum = numbers[i];

            if (currentNum > previousNum){
                temp.add(previousNum);
                count++;
            } else {
                if (count > maxCount){
                    temp.add(previousNum);
                    result.clear();
                    result.addAll(temp);
                    maxCount = count;
                }
                count = 0;
                temp.clear();
            }

            previousNum = currentNum;
        }

        if (count > maxCount){
            temp.add(previousNum);
            result.clear();
            result.addAll(temp);
        }

        Iterator iterator = result.iterator();

        while (iterator.hasNext()){
            System.out.print(iterator.next() + " ");
        }
    }
}
