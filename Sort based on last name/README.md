Write a sorting function that takes in an array of names and sorts them by last name either alphabetically (ASC) or reverse-alphabetically (DESC) using ASP.net
SortContacts(new string[] {
"John Locke",
"Thomas Aquinas",
"David Hume",
"Rene Descartes"
}, "ASC") ➞ {
"Thomas Aquinas",
"Rene Descartes",
"David Hume",
"John Locke"
}
// Aquinas (A) < Descartes (D) < Hume (H) < Locke (L)

SortContacts(new string[] {
"Paul Erdos",
"Leonhard Euler",
"Carl Gauss"
}, "DESC") ➞ {
"Carl Gauss",
"Leonhard Euler",
"Paul Erdos"
}

// Gauss (G) > Erdos (ER) > Euler (EU)

SortContacts([], "DESC") ➞ {}

SortContacts(null, "DESC") ➞ {}
Notes
An array with a single name should be trivially returned.
An empty array, or an input of null should return an empty array..
