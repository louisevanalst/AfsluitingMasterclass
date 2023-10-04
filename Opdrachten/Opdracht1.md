#Opdracht 1 - Create Sendgrid account

## Sign up for sendgrid
1. Ga naar www.signup.sendgrid.com
2. Sign up met je harvest account
3. Vul in de informatie:
   - Company Name: Harvest
   - Company Website: www.harvest.nl
   - Role: Developer
   - Emails per month: 0-100.000
   - Employees: 1-500
4. Klik op get started. Je krijgt een email waarmee je two factor authentication aan kan zetten via sms. Als dit gelukt is kun je inloggen met je harvest email en net gemaakte wachtwoord.

## Voeg een email toe
5. Als je ingelogd bent, zoek links het tabje "Settings" en klik op "Sender Authentication".
6. Op het scherm zie je naast "Single Sender Verification" een tabje met "Get Started" onder Verfify an Address, klik daarop.
7. Vul de informatie in in het Create a Sender Scherm:
   - From Name: je eigen voor en achternaam
   - From Email Address: je eigen harvest email
   - Reply To: je eigen harvest email
   - Company Address: Hoofdstraat 152
   - City: Driebergen-Rijsenburg
   - Zip Code: 3972 LE
   - Country: Netherlands
   - Nickname: je voornaam
8. Klik op Create en daarna op "Verify Single Sender", je krijgt een email op je harvest account waarmee je dit kan verifieëren.

## Maak een API key
9. Ga terug naar het tabje "Settings" links en klik op "API Keys", en daarna rechtsboven op "Create API Key"
10. Vul de informatie in in het Create API Key Scherm:
    - API Key Name: HarvestEmailSender
    - API Key Permissions: Restricted Access
    - Access Details > Mail Send > Mail Send > Sleep de slider helemaal naar rechts (hij wordt dan blauw).
11. Click op Create & View
12. **IMPORTANT** Je krijgt nu een API Key Created scherm te zien en **KOPIEER DE KEY NU NAAR JE NOTITIES** deze heb je later nodig.
13. All set :)
