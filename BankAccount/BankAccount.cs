using System;

class BankAccount
{
    private string accountNumber;
    private string ownerName;
    private int balance;

    public string AccountNumber { get { return accountNumber; } }
    public string OwnerName { get { return ownerName; } }
    public  int Balance { get { return balance; } }

    public BankAccount(string accountNumber, string ownerName)
    {
        this.accountNumber = accountNumber;
        this.ownerName = ownerName;
        balance =  0;
    }

    public void Deposit(int amount)
    {
        if(amount < 0)
        {
            Console.WriteLine("입금 금액은 0보다 커야 합니다.");
        }
        else
        {
            balance += amount;
            Console.WriteLine($"{amount}원 입금 완료. 잔액: {Balance}원");
        }
    }

    public void Withdraw(int amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("잔액이 부족합니다.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"{amount}원 출금 완료. 잔액: {Balance}원");
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"[계좌 정보] {AccountNumber} ({OwnerName}) - 잔액: {Balance}원");
    }
}