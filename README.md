# 13.3-json
Das bestehende Projekt soll so erweitert werden, dass vorhandene Lieferungs-Objekte in einem json exportiert werden. In der `Program.cs`werden drei Objekte erzeugt, deren Export als json exakt so aussehen sollte:
```json
{
	"anzahl": 3,
	"lieferungen":
	[
		{
			"datum": "2024-06-22",
			"sendungsnummer": "HHX05NNW0ZP",
			"plz": 86309
		},
		{
			"datum": "2024-09-4",
			"sendungsnummer": "GSV18EDC4BR",
			"plz": 91139
		},
		{
			"datum": "2023-04-8",
			"sendungsnummer": "CQX55KMY5RW",
			"plz": 7708
		}
	]
}
```

## Arbeitsauftrag
- Informieren Sie sich über den allgmeinen Aufbau von json-Dateien.
- Fassen Sie Ihre Erkenntnisse in einem kurzen "Spickzettel" zusammen.
- Erweitern Sie Ihr Programm so, dass eine JSON-Datei nach obigem Vorbild erstellt wird.
- Nutzen Sie, nach Möglichkeit, keine fertige Bibliothek.
- Ob die Datei korrekt formatiert ist, können Sie z.B. [hier](https://jsonlint.com/) überprüfen.
