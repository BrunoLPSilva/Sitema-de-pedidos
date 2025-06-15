export interface Pedido {
    id?: number; // <- adicione isso
  cliente: string;
  status: string;
  itens: {
    nomeProduto: string;
    quantidade: number;
    precoUnitario: number;
  }[];
}
