namespace learn_object_oriented_programming_in_c_sharp.OOPs;
/*
 * Encapsulation:
  1. Private fields + public getters/setters
  2. Protects data from direct access
 */
class BankAccount
{
  private int balance;
  
  // setter
  public void setBalance(int balance)
  {
    this.balance = balance;
  }
  // getter
  public int getBalance()
  {
    return balance;
  }
}