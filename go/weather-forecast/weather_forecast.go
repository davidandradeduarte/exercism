// Package weather provides a functionalities to get the weather forecast.
package weather

// CurrentCondition is the current weather condition.
var CurrentCondition string

// CurrentLocation is the current weather location.
var CurrentLocation string

// Forecast returns the weather forecast for the current city.
func Forecast(city, condition string) string {
	CurrentLocation, CurrentCondition = city, condition
	return CurrentLocation + " - current weather condition: " + CurrentCondition
}
