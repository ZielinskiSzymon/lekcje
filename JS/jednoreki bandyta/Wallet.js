class Wallet {
  #money;

  constructor(money) {
    this.#money = money;
  }

  getWalletValue() {
    return this.#money;
  }

  checkCanPlay(value) {
    if (this.#money >= value) {
      return true;
    }
    return false;
  }

  changeWallet(value, type = "+") {
    if (typeof value === "number" && !isNaN(value)) {
      if (type === "+") {
        return (this.#money += value);
      } else if (type === "-") {
        return (this.#money -= value);
      } else {
        throw new Error("Invalid type of operation");
        //throw - wyrzuca błąd i przerywa działanie funkcji
      }
    } else {
      console.log(typeof value);
      throw new Error("Invalid number");
    }
  }
}

const wallet = new Wallet(1000);
// console.log(wallet.getWalletValue())
// console.log(wallet.changeWallet(200, "+"));
// console.log(wallet.getWalletValue());
// console.log(wallet.changeWallet(200, "-"));
// console.log(wallet.getWalletValue());
// console.log(wallet.checkCanPlay(100));
