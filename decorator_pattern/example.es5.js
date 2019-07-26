function Hero(strength) {
    this.strength = strength
    this.decorators = []
}

Hero.prototype.getStrength = function() {
    var totalStrength = this.strength
    for (var decorator of this.decorators) {
        totalStrength += decorator.getPercentStrengthen() * this.strength
    }
    return totalStrength
}

Hero.prototype.render = function() {
    var decoratorsName = this.decorators.map(function(o) {return o.getName()})    
    console.log('Hero with ', decoratorsName.join(','))
}

Hero.prototype.decorate = function(decorator) {
    this.decorators.push(decorator)
}

function HeroDecorator(name, percentStrengthen) {
    this.name = name
    this.percentStrengthen = percentStrengthen
}

HeroDecorator.prototype.getPercentStrengthen = function() {
    return this.percentStrengthen
}

HeroDecorator.prototype.getName = function() {
    return this.name
}

function Hat(name) {
    HeroDecorator.call(this, name, 10/100)    
}

Hat.prototype = Object.create(HeroDecorator.prototype)
Hat.prototype.constructor = Hat

function Ring(name) {
    HeroDecorator.call(this, name, 20/100)        
}

Ring.prototype = Object.create(HeroDecorator.prototype)
Ring.prototype.constructor = Ring

var hero = new Hero(100)
hero.decorate(new Hat("a red hat"))
hero.decorate(new Ring("a diamon ring"))
hero.render()
console.log(hero.getStrength())
