

export class Game {
    name: string
    team1: string
    team2: string
    type: string
    location: string
    award: number
    constructor(name: string, team1: string, team2: string, type: string, location: string, award: number) {
        this.name = name
        this.team1 = team1
        this.team2 = team2
        this.type = type
        this.location = location
        this.award = award
    }

    print() {
        console.log(this.name + "   " + this.team1 + "   " + this.team2 + "   " + this.type + "   " + this.location + "   " + this.award)
    }
}