using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
       // Set the initial seed number
       _numSeedsLeft = _numSeeds;
       
       // The initial planted number is 0
       _numSeedsPlanted = 0;
       
       // Update the UI display
       _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);  
    }

    private void Update()
    {
        // Use WASD or arrow keys to get player input and control horizontal and vertical movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
       
        // Create a new movement vector and update the player position based on speed and time increments
        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        _playerTransform.position += movement * _speed * Time.deltaTime;

        // Detect when the space bar is pressed, and if pressed, plant the seed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        } 
    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft > 0)
        {
            // Spawn plants at the player's current location
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
            
            // Reduce the number of remaining seeds and increase the number planted
            _numSeedsLeft--;
            _numSeedsPlanted++;

            // Update UI
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        } 
    }
}
