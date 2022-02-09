package techpalace

import (
	"bufio"
	"fmt"
	"strings"
)

// WelcomeMessage returns a welcome message for the customer.
func WelcomeMessage(customer string) string {
	return fmt.Sprintf("Welcome to the Tech Palace, %s", strings.ToUpper(customer))
}

// AddBorder adds a border to a welcome message.
func AddBorder(welcomeMsg string, numStarsPerLine int) string {
	b := &strings.Builder{}
	for i := 0; i < numStarsPerLine; i++ {
		b.WriteString("*")
	}
	b.WriteString(fmt.Sprintf("\n%s\n", welcomeMsg))
	for i := 0; i < numStarsPerLine; i++ {
		b.WriteString("*")
	}
	return b.String()
}

// CleanupMessage cleans up an old marketing message.
func CleanupMessage(oldMsg string) string {
	b := &strings.Builder{}
	s := bufio.NewScanner(strings.NewReader(oldMsg))
	for s.Scan() {
		b.WriteString(strings.Trim(strings.ReplaceAll(s.Text(), "*", ""), " "))
	}
	return strings.Trim(b.String(), " ")
}
