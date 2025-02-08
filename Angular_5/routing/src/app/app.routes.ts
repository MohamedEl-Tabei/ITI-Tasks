import { Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { UsersDetailsComponent } from './components/users-details/users-details.component';
import { ErrorComponent } from './components/error/error.component';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'users', component: HomeComponent },
  { path: 'users/:id', component: UsersDetailsComponent },
  { path: '**', component: ErrorComponent },
];
