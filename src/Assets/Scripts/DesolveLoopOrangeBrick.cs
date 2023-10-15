using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesolveLoopOrangeBrick : MonoBehaviour
{
    const float DISPLAY = 1.5f;
    const float NEXT = 1.501f;
    const float WAIT = 1.502f;
    const float DESOLVE_START = 0f;
    const float DESOLVE_END = 1f;
    const float _waitTime = 5f;
    const float _nextTime = 1f;
    float _desolveTime = 0f;
    bool _desolveFlag = true;
    bool _prepared = false;

    [SerializeField] private Transform _brick;
    [SerializeField] Material _material;
    MeshRenderer _meshRenderer;

    IEnumerator DesolveWait()
    {
        _desolveTime = DESOLVE_END;
        _meshRenderer.material.SetFloat("_threshold", _desolveTime);
        _brick.transform.position = new Vector3(0, 0, WAIT);

        yield return new WaitForSeconds(_waitTime);

        _desolveTime = DESOLVE_START;
        _meshRenderer.material.SetFloat("_threshold", _desolveTime);
        _brick.transform.position = new Vector3(0, 0, NEXT);

        yield return new WaitForSeconds(_nextTime);

        _brick.transform.position = new Vector3(0, 0, DISPLAY);
        _desolveFlag = false;
    }

    IEnumerator PrepareCoroutine()
    {
        yield return new WaitForSeconds(_nextTime);

        _brick.transform.position = new Vector3(0, 0, DISPLAY);
        _desolveFlag = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.material = _material;
        _meshRenderer.material.SetFloat("threshold", DESOLVE_START);
    }  

    // Update is called once per frame
    void Update()
    {
        if (!_prepared)
        {
            StartCoroutine(PrepareCoroutine());
            _prepared = true;
        }

        if (!_desolveFlag)
        {
            if (_desolveTime >= DESOLVE_END)
            {
                StartCoroutine(DesolveWait());
                _desolveFlag = true;
            }
            else
            {
                _desolveTime += Time.deltaTime;
                _meshRenderer.material.SetFloat("_threshold", _desolveTime);
            }
        }
    }
}
