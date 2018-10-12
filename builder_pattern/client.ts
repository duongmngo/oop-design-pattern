import { Game} from './game'
import { GameBuilder } from './gameBuilder'


// create a class without builder pattern
const game  = new Game('1', '2', '3', '4', '5', 100)
game.print()


// create a class with builder pattern
const gameBuilder = new GameBuilder()
                        .setName('name')
                        .setTeam1('team1')
                        .setTeam2('team2')
                        .setType('type')
                        .setLocation('location')
                        .setAward(1000)
                        .build()