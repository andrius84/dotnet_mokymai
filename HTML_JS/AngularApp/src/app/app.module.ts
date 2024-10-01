import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { LithuaniaComponent } from './lithuania/lithuania.component';
import { FranceComponent } from './france/france.component';
import { ItalyComponent } from './italy/italy.component';

@NgModule({
  declarations: [
    AppComponent,
    LithuaniaComponent,
    FranceComponent,
    ItalyComponent
  ],
  imports: [BrowserModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }