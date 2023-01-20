import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DialogComponent } from './dialog/dialog.component';
import { LoginComponent } from './login/login.component';
import { ResUsersComponent } from './res-users/res-users.component';

const routes: Routes = [
  {path : '', component : LoginComponent},
  {path : 'res', component : ResUsersComponent},
  {path:'popup',component:DialogComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
