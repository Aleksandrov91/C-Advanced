package com.company;

import java.util.Scanner;
import java.util.TreeMap;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        TreeMap<String, Double> sumbsByTowns = new TreeMap<>();

        for (int i = 0; i < n; i++) {
            String[] tokens = scanner.nextLine().split("\\|");
            String town = tokens[0].trim();
            double income = Double.parseDouble(tokens[1].trim());

            if (!sumbsByTowns.containsKey(town)){
                sumbsByTowns.put(town, income);
            } else {
                sumbsByTowns.put(town, sumbsByTowns.get(town) + income);
            }
        }

        for (String kvp : sumbsByTowns.keySet()){
            System.out.println(kvp + " -> " + sumbsByTowns.get(kvp));
        }
    }
}
