package com.company;

public class Main {
    public static double getRandomNumber(double min, double max){
        double x = (int)(Math.random()*((max-min)+1))+min;
        return x;
    }
    private static int prostNumber(int a)
    {
        for (int i=2; i<a; i++)
        {
            if (a%i == 0)
            {
                return 0;
            }

            if ((i==a) || (i>Math.sqrt(a)))
            {
                return 1;
            }
        }

        return 0;
    }
    public static void main(String[] args) {
        int arr[][] = new int[8][8];
        for (int i = 0; i < 8; i++) {//№1
            for (int j = 0; j < 8; j++) {
                if (j % 2 == 0) {
                    if (i % 2 == 0) {
                        arr[i][j] = 1;
                    } else {
                        arr[i][j] = 0;
                    }
                } else {
                    if (i % 2 == 0) {
                        arr[i][j] = 0;
                    } else {
                        arr[i][j] = 1;
                    }
                }
                System.out.print(arr[i][j] + " \t");
            }
            System.out.println();
        }
        double [][] randomNumber =new double [10][10];//№2
        int [] sum = new int [10];
        for(int i=0;i<10;i++){
            for(int j=0;j<10;j++){
                randomNumber[i][j]=getRandomNumber(0,100);
                System.out.print((int)randomNumber[i][j]+"\t ");
            }
            System.out.println();
        }
        for(int i=0;i<10;i++){
            for(int j=0;j<10;j++){
                sum[i]=sum[i]+(int)randomNumber[i][j];
            }
            System.out.println("Сумма "+i+" строки: "+sum[i]);
        }
        for(int i=0;i<10;i++){
            for(int j=0;j<10;j++) {
                if (prostNumber((int) randomNumber[i][j]) == 1) {
                    System.out.print((int)randomNumber[i][j]+" ");
                }
            }
        }
    }
}
