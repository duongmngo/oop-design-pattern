

export class GameBuilder {
    private name
    private team1: string
    private team2: string
    private type: string
    private location: string
    private award: number

    setName(name: string) {
        this.name = name
        return this
    }
    setTeam1(team1: string) {
        this.team1 = team1
        return this
    }
    setTeam2(team2: string) {
        this.team2 = team2
        return this
    }
    setType(type: string) {
        this.type = type
        return this
    }
    setLocation(location: string) {
        this.location = location
        return this
    }
    setAward(award: number) {
        this.award = award
        return this
    }

    build() {
        if (!this.name) {
            throw "this field cannot be null"
        } if (!this.team1) {
            throw "this field cannot be null"
        } if (!this.team2) {
            throw "this field cannot be null"
        } if (!this.type) {
            throw "this field cannot be null"
        } if (!this.location) {
            throw "this field cannot be null"
        } if (!this.award) {
            throw "this field cannot be null"
        }
        console.log(this.name + "   " + this.team1 + "   " + this.team2 + "   " + this.type + "   " + this.location + "   " + this.award)
        return this
    }
}


