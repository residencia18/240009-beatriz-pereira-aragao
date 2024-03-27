import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroComponent } from './cadastro/cadastro.component';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { AuthGuard } from './guards/authorization.guard';
import { MinhaProducaoComponent } from './minha-producao/minha-producao.component';
import { SessaoComponent } from './sessao/sessao.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent,
    children: [
      { path: 'login', component: LoginComponent },
      { path: '', component: CadastroComponent },
    ],
  },
  { path: 'dashboard', component: DashboardComponent },
  {
    path: 'dashboard',
    component: DashboardComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'sessao', component : SessaoComponent,
    canActivate: [AuthGuard],
  },

  { path: 'teste', component: MinhaProducaoComponent },
  { path: '**', redirectTo: '' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
