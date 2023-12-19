# Develhope, Checkpoint .NET ita 2 - Sistema di Prenotazione Alberghiera

## Panoramica
Questo esercizio consiste nello sviluppo di un sistema di prenotazione alberghiera utilizzando .NET. Gli studenti sono chiamati a implementare diverse funzionalità chiave, utilizzando API RESTful, programmazione asincrona e LINQ.

## Obiettivi
- Creare API RESTful per gestire le prenotazioni di un hotel.
- Implementare operazioni asincrone.
- Utilizzare LINQ per interrogare e manipolare i dati.

## Requisiti Specifici

### Parte 1: API RESTful
- Implementare endpoint per (in ordine di priorità):
  - **Elenco Camere**: Visualizzare tutte le camere.
  - **Elenco Camere Disponibli**: Visualizzare tutte le camere disponibili a una certa data (disponibili == non esistono prenotazioni).
  - **Prenotazione Camera**: Prenotare una camera specifica.
  - **Cancellazione Prenotazione**: Annullare una prenotazione esistente.
  - **Dettagli Camera**: Ottenere dettagli su una specifica camera (incluse le sue prenotazioni).
  - **Creazione Camera**: Creare una camera.
  - **Modificare Camera**: Modificare una camera.
  - **Cancellare Camera**: Eliminare una camera.

### Parte 2: Programmazione Asincrona
- Gestire le richieste in modo asincrono.

### Parte 3: LINQ
- Utilizzare LINQ per:
  - Filtrare le camere in base a criteri specifici (es. disponibilità, prezzo, numero di persone).
  - Ordinare le camere in base al prezzo.
