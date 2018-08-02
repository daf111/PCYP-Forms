using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsianOptions
{

    /// <summary>
    /// Calculates the price of an asian options based on the given statistical context.
    /// El método de Montecarlo es un método no determinista o estadístico numérico, usado
    /// para aproximar expresiones matemáticas complejas y costosas de evaluar con exactitud.
    /// La Simulación de Montecarlo es una técnica que permite llevar a cabo la valoración
    /// de los proyectos de inversión considerando que una, o varias, de las variables que
    /// se utilizan para la determinación de los flujos netos de caja no son variables
    /// ciertas, sino que pueden tomar varios valores.
    /// Por tanto, se trata de una técnica que permite introducir el riesgo en la valoración
    /// de los proyectos de inversión.
	/// </summary>
	public class AsianOptionsPricing
	{

		/// <summary>
		/// Calculates the price of an option with the given statistical info.
		/// The algorithm used for calculation is the Monte Carlo method.
		/// </summary>
		/// <param name="rand">Random number generator.</param>
		/// <param name="initial">Initial price.</param>
		/// <param name="exercise">Excercise price.</param>
		/// <param name="up">Up growth.</param>
		/// <param name="down">Down growth.</param>
		/// <param name="interest">Intrest rate.</param>
		/// <param name="periods">Number of periods to maturity.</param>
		/// <param name="sims">Number of simulations to perform.</param>
		/// <returns>The calculated value for an option with the given 
		/// statistical context using the Monte Carlo method.</returns>
		///
		public static double Simulation(Random rand, double initial, double exercise, double up, double down, double interest, long periods, long sims)
		{
			// Risk-neutral probabilities:
			double piup = (interest - down) / (up - down);
			double pidown = 1 - piup;

			double sum = 0.0;

			// Run simulations:
			for (int index = 0; index < sims; index++)
			{
				// Generate one path:
				double sumPricePath = initial;
				double previous = initial;
				double next;

				for (int i = 1; i <= periods; i++)
				{
					double rn = rand.NextDouble();

					if (rn > pidown)
					{
						next = previous * up;
					}
					else
					{
						next = previous * down;
					}

					sumPricePath += next;
					previous = next;
				}

				double priceAverage = sumPricePath / (periods + 1);
				double callPayOff = Math.Max(priceAverage - exercise, 0);

				sum += callPayOff;
			}

			// Return average across all simulations:
			return (sum / Math.Pow(interest, periods)) / sims;
		}

	}//class
}//namespace