import { ListarPedidosComponent } from './pages/listar-pedidos/listar-pedidos.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CriarPedidoComponent } from './pages/criar-pedido/criar-pedido.component';
import { AtualizarStatusComponent } from './pages/atualizar-status/atualizar-status.component';

const routes: Routes = [
  { path: '', component: ListarPedidosComponent },
  { path: 'criar', component: CriarPedidoComponent},
  { path: 'pedidos/:id/status', component: AtualizarStatusComponent },


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
