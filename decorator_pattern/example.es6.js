class Hero {
    constructor(strength) {
        this.strength = strength
        this.decorators = []
    }

    getStrength() {
        var totalStrength = this.strength
        for (var decorator of this.decorators) {
            totalStrength += decorator.getPercentStrengthen() * this.strength
        }
        return totalStrength
    }

    decorate(decorator) {
        this.decorators.push(decorator)
    }

    render() {
        var decoratorsName = this.decorators.map(function(o) {return o.getName()})    
        console.log('Hero with ', decoratorsName.join(','))
    }
}

class HeroDecorator {
    constructor(name, percentStrengthen) {
        console.log(`${name} - ${percentStrengthen}`)
        this.name = name
        this.percentStrengthen = percentStrengthen
    }

    getName() {
        return this.name
    }

    getPercentStrengthen() {
        return this.percentStrengthen
    }
}

class Hat extends HeroDecorator {        
    constructor(name) {
        super(name, 10/100)
    }
}

class Ring extends HeroDecorator {    
    constructor(name) {
        super(name, 20/100)
    }
}

var hero = new Hero(100)
hero.decorate(new Hat("a red hat"))
hero.decorate(new Ring("a diamon ring"))
hero.render()
console.log(hero.getStrength())