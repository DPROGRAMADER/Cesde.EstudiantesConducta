import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { conductaEstudiante } from '../models/conductaEstudiante';
import { Observable, } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ConductaEstudianteService {

  baseUrlApi: string = ""

  constructor(private http: HttpClient) {
    this.baseUrlApi = `${environment.baseUrlApi}/ EstudianteController`
  }

  postEstudianteController(from: conductaEstudiante): Observable<conductaEstudiante> {
    return this.http.post<conductaEstudiante>(`${this.baseUrlApi}/CrearConductaEstudiante`, from)
  }
  putEstudianteController(from: conductaEstudiante): Observable<conductaEstudiante> {
    return this.http.put<conductaEstudiante>(`${this.baseUrlApi}/EditarConductaEstudiante`, from)
  }
  deleteEstudianteController(id: number): Observable<any> {
    return this.http.delete<conductaEstudiante>(`${this.baseUrlApi}/EliminarConductaEstudiante/${id}`,)
  }
  getEstudianteController(): Observable<conductaEstudiante[]> {
   return this.http.get<conductaEstudiante[]>(
    `${environment.baseUrlApi}/Estudiante/ConsultarConductasEstudiantes`
   )
  }
}
    
