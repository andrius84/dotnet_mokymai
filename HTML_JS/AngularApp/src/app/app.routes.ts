import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FlagsComponent } from './flags/flags.component'; // Import the new component
import { LithuaniaComponent } from './lithuania/lithuania.component';
import { FranceComponent } from './france/france.component';
import { ItalyComponent } from './italy/italy.component';

const routes: Routes = [
  { path: '', redirectTo: '/flags', pathMatch: 'full' }, // Redirect to flags by default
  { path: 'flags', component: FlagsComponent },
  { path: 'lithuania', component: LithuaniaComponent },
  { path: 'france', component: FranceComponent },
  { path: 'italy', component: ItalyComponent },
  { path: '**', redirectTo: '/flags' } // Wildcard redirect
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
