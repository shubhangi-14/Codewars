// Create a function that returns the name of the winner in a fight between two fighters.

// Each fighter takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having health <= 0.

// Each fighter will be a Fighter object/instance. See the Fighter class below in your chosen language.

// Both health and damagePerAttack (damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.
public class Kata {
  public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker) {
    while (fighter1.Health > 0 && fighter2.Health > 0) {
    fighter2.Health -= fighter1.DamagePerAttack;
    fighter1.Health -= fighter2.DamagePerAttack;
  }
  
  if (fighter1.Health <= 0 && fighter2.Health <= 0)
    return firstAttacker;
  else if (fighter1.Health <= 0)
    return fighter2.Name;
  else
    return fighter1.Name;
  }
}