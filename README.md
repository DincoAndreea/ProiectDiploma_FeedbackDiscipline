Am realizat acest proiect cu scopul de a veni în ajutor facultății și cadrelor didactice ce vor să își îmbunătățească prestația didactică, suportul de curs și materialele didactice utilizate la alte activități didactice din cadrul Facultății de Inginerie Electrică și Știința Calculatoarelor, cât și relația dintre cadrele didactice și studenți, o comunicare sinceră și constructivă dintre cei doi parteneri din procesul educațional fiind benefică pentru ambele părți ce au ca scop comun excelența academică și progresul continuu. 

În cadrul acestui proiect am vrut să mă concentrez pe evaluarea materialelor didactice folosite de profesori la cursuri, laboratoare, seminare, proiecte, neluând în calcul evaluarea cadrului didactic și conduita acestuia în timpul activităților didactice. 

În cadrul facultății există un sistem de evaluare al cadrelor didactice semestrială care se concentrează mai mult pe conduita și relația acestora cu studenții și mai puțin pe materialele didactice folosite, în special caracteristicile și funcționalitățile acestora.

Sistemul de evaluare din acest proiect este reprezentat de un chestionar ce va fi completat de către studenți după fiecare activitate didactică la care au fost prezenți, nefiind luate în considerare răspunsurile la activitățile la care nu au fost prezenți, asemănător cu sistemul de evaluare al profesorilor.

Ce este diferit la acest sistem de evaluare este faptul că evaluarea nu se va face semestrială, ci după fiecare activitate didactică. De asemenea, nu este o aplicație web în browser ci o aplicație mobilă Android și iOS. Utilizatorii acestei aplicații vor fi studenții, cadrele didactice și administratorul. Cele trei tipuri de utilizatori vor avea roluri diferite în cadrul aplicației și sunt bine delimitate. Conturile utilizatorilor vor fi deja create, asemănător cu cele folosite de studenți pe platforma Moodle, ceea ce înseamnă ca parola nu va putea fi modificată.

Rolul de student va presupune completarea unui chestionar ce va avea în vedere ciclul de studii al disciplinei ce dorește să o evalueze, anul de studiu în care se află, programul de studiu al disciplinei, disciplina, tipul de activitate la care a participat (seminar, curs, laborator, proiect), numărul activității/activităților pe care dorește să o/le evalueze (ex. cursul cu numărul șapte), activitățile la care a fost prezent, întrebări cu un singur răspuns, întrebări cu răspunsuri multiple, întrebări semantice în scară și întrebări deschise. Studentul va putea evalua doar o singură dată o anumită activitate didactică și nu va avea posibilitatea de a-și modifica răspunsurile.

Rolul de cadru didactic (profesor) va reprezenta posibilitatea de a vizualiza un raport al evaluărilor făcute de studenți la orice disciplină din cadrul facultății. Acesta va putea vedea toate răspunsurile studenților la întrebările cu răspuns liber și diagrame cu linii pentru întrebările semantice în scară, având o perspectivă mai bună asupra preferințelor studenților.

Rolul de administrator este reprezentat de gestionarea conturilor utilizatorilor, înregistrarea și ștergerea acestora. 

În prezent nu există un sistem de evaluare privind calitatea actului didactic înglobat într-o aplicație mobilă, aceste evaluări fiind fie efectuate pe foi de hârtie sau într-o aplicație web în browser. Alte sisteme de evaluare al calității actului didactic vizează mai mult cadrul didactic și sistemul de examinare folosit de acesta, criteriile ce țin de materiale didactice nefiind evidențiate așa bine.

Ca și realizări personale menționez dezvoltarea aplicației mobile Android și iOS folosind framework-ul Xamarin.Forms, crearea schemei bazei de date MySQL și găzduirea acesteia în cloud prin serviciul Amazon RDS și dezvoltarea API-ului prin framework-ul ASP.NET Core ce va asigura comunicarea dintre aplicația mobilă și baza de date, de asemenea găzduit în cloud pe platforma AWS Lambda. 

În cadrul aplicației mobile am creat interfața grafică pentru pagina ce va afișa chestionarul, pagina de administrare a utilizatorilor, pagina de logare și pagina de rapoarte, mecanismul de conectare și deconectare a utilizatorului, metodele ce țin de preluarea datelor din chestionar și salvarea acestora în baza de date, metodele de prelucrare a răspunsurilor date de studenți și afișarea acestora sub forma unor grafice unde este cazul.

În baza de date am creat tabelele în care vor fi stocate date despre ciclurile de studii, programele de studiu, anii de studiu, disciplinele, tipurile de activități, întrebările din chestionar, răspunsurile date de studenți, datele despre evaluare, utilizatori, rolurile utilizatorilor, token-urile de acces și cele de reîmprospătare, atributele ce țin de roluri și utilizatori, migrațiile din cadrul proiectului și date despre conectarea utilizatorilor. De menționat că tabelele ce conțin date despre migrații, atributele rolurilor și utilizatorilor, conectarea utilizatorilor, rolurile și rolurile utilizatorilor, utilizatori și token-urile de acces ale acestora au fost generate automat de API-ul ASP.NET Core Identity pentru a implementa funcționalități de gestionare a utilizatorilor.

În API-ul web am creat metodele de preluare a datelor despre anii de studiu, ciclurile de studii, discipline, programe de studiu, tipurile de activități, rapoarte și metodele de salvare în baza de date a informațiilor despre utilizatorii noi înregistrați, datele de logare precum și acordarea token-urilor de acces și reîmprospătare și autorizarea și autentificarea utilizatorilor în funcție de rolul acestora.
Proiectul final reprezintă un sistem format din aceste trei componente interconectate între ele, sistem cu care interacționăm prin intermediul aplicației mobile ce se folosește de serviciile web care vor prelua și salva date din și în baza de date.
