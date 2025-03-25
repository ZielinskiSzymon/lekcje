//tworzaca obiekt za kazda gra
class Draw {
  #result;

  constructor() {
    this.options = ["red", "green", "blue"];
    this.#result = this.drawResult();
  }

  drawResult() {
    let colors = [];
    for (let i = 0; i < this.options.length; i++) {
      const index = Math.floor(Math.random() * this.options.length);
      const color = this.options[index];
      colors.push(color);
    }
    return colors;
  }

  getDrawResult() {
    return this.#result;
  }
}

const draw = new Draw();
console.log(draw.getDrawResult());
