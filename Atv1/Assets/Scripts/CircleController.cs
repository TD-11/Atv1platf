using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CircleController : MonoBehaviour
{
   private SpriteRenderer _spriteRenderer;
   
   [Header("Listening on...")]
   public VoidEventChannel circleColorEvent;
   public ColorEventChannel circleSpecificColorEvent;

   private void Awake()
   {
      _spriteRenderer = GetComponent<SpriteRenderer>();
   }

   private void OnEnable()
   {
      circleColorEvent.OnEventRaised += MudaCor;
      circleSpecificColorEvent.OnEventRaised += MudaCorEspecifica;
   }

   private void OnDisable()
   {
      circleColorEvent.OnEventRaised -= MudaCor;
      circleSpecificColorEvent.OnEventRaised -= MudaCorEspecifica;
   }

   public void MudaCor()
   {
      _spriteRenderer.color = Random.ColorHSV();
   }

   public void MudaCorEspecifica(Color corEspecifica)
   {
      _spriteRenderer.color = corEspecifica;
   }
   
}
